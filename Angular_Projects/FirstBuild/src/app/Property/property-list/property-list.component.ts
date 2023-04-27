import { Component, OnInit } from '@angular/core';
import { Router } from '@angular/router';
import { HousingService } from 'src/app/services/housing.service';

@Component({
  selector: 'app-property-list',
  templateUrl: './property-list.component.html',
  styleUrls: ['./property-list.component.scss']
})
export class PropertyListComponent implements OnInit{

  constructor(private housingService:HousingService){}
  properties:any;

  ngOnInit() {
    this.housingService.getAllProperties().subscribe(data=>{
      this.properties = data;
    })
   }


}
