import { Component, OnInit } from '@angular/core';
import { ActivatedRoute, Router } from '@angular/router';
import { HousingService } from 'src/app/services/housing.service';

@Component({
  selector: 'app-property-list',
  templateUrl: './property-list.component.html',
  styleUrls: ['./property-list.component.scss']
})
export class PropertyListComponent implements OnInit{
  properties:Array<any>=[];
  SellRent = 1;
  City:string = '';
  SearchCity:string = '';
  SortbyParam:string = '';
  SortDirection = 'asc';

  constructor(private activatedRoute:ActivatedRoute,private housingService:HousingService){}


  ngOnInit() {
    if(this.activatedRoute.snapshot.url.toString()){
      this.SellRent = 2; // Means we are on rent-property URL else we are on base URL
    }
    this.housingService.getAllProperties(this.SellRent).subscribe(data=>{
      this.properties = data;
      // console.log(this.activatedRoute.snapshot.url.toString());
      const newProperty = JSON.parse(localStorage.getItem('newProp') || '');
      if(newProperty.SellRent === this.SellRent ){
        this.properties = [newProperty,...this.properties];
      }

    },error=>{
      console.log(error);
    })

   }

   onCityFilter(){
    this.SearchCity = this.City;
   }

   onCityFilterClear(){
    this.SearchCity = '';
    this.City = '';
   }

   onSortDirection(){
    if(this.SortDirection === 'desc'){
      this.SortDirection = 'asc';
    }else{
      this.SortDirection = 'desc';
    }
   }

}
