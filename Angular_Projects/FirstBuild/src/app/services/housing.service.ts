import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Observable, map } from 'rxjs';
import { IPropertyBase } from '../model/ipropertybase';


interface PropertyData {
  [key: string]: any; // define the properties as any type
}

@Injectable({
  providedIn: 'root'
})

export class HousingService {


  constructor(private http:HttpClient) { }

  getAllProperties(SellRent:number):Observable<IPropertyBase[]>{
    return this.http.get<PropertyData>('data/properties.json').pipe(
      map(data => {
        const propertiesArray:Array<IPropertyBase> = [];
        for (const id in data) {
          if (data.hasOwnProperty(id) && data[id].SellRent === SellRent) {
            propertiesArray.push(data[id]);
          }
        }
        return propertiesArray;
      })
  )}
}
