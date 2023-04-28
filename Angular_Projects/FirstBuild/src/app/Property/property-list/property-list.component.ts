import { Component, OnInit } from '@angular/core';
import { ActivatedRoute, Router } from '@angular/router';
import { HousingService } from 'src/app/services/housing.service';
import { IProperty } from '../Iproperty.interface';

@Component({
  selector: 'app-property-list',
  templateUrl: './property-list.component.html',
  styleUrls: ['./property-list.component.scss']
})
export class PropertyListComponent implements OnInit{
  properties:Array<IProperty>=[];
  SellRent = 1;

  constructor(private activatedRoute:ActivatedRoute,private housingService:HousingService){}


  ngOnInit() {
    if(this.activatedRoute.snapshot.url.toString()){
      this.SellRent = 2; // Means we are on rent-property URL else we are on base URL
    }
    this.housingService.getAllProperties(this.SellRent).subscribe(data=>{
      this.properties = data;
      console.log(this.activatedRoute.snapshot.url.toString());
    },error=>{
      console.log(error);
    })

   }


}
