import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Observable, map } from 'rxjs';
import { IPropertyBase } from '../model/ipropertybase';
import { Property } from '../model/property';
import { Iproperty } from '../model/iproperty';


interface PropertyData {
  [key: string]: any; // define the properties as any type
}

@Injectable({
  providedIn: 'root'
})

export class HousingService {


  constructor(private http:HttpClient) { }

  getProperty(id:number){
    return this.getAllProperties().pipe(
      map(propertiesArray=>{
        return propertiesArray.find(p=> p.Id === id);
      })
    );
  }

  getAllProperties(SellRent?:number):Observable<Property[]>{
    return this.http.get<PropertyData>('data/properties.json').pipe(
      map(data => {
        const propertiesArray:Array<Property> = [];
        const localProperties= JSON.parse(localStorage.getItem('newProp') || '');

        if(localProperties){
          for(const id in localProperties){
            if(SellRent){
            if(localProperties.hasOwnProperty(id) && localProperties[id].SellRent == SellRent){
              propertiesArray.push(localProperties[id]);
            }
          }else{
            propertiesArray.push(localProperties[id]);
          }
          }
        }



        for (const id in data) {
          if(SellRent){
          if (data.hasOwnProperty(id) && data[id].SellRent === SellRent) {
            propertiesArray.push(data[id]);
          }
        }else{
          propertiesArray.push(data[id]);
        }
        }
        return propertiesArray;
      })
  );
  return this.http.get<Property[]>('data/properties.json')
}


  addProperty(property:Property){
    localStorage.setItem('newProp',JSON.stringify(property));
  }


}
