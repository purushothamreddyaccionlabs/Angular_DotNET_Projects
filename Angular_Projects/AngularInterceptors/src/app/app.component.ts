import { Component } from '@angular/core';
import { APIServicesService } from './apiservices.service';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.scss']
})
export class AppComponent {
  title = 'AngularInterceptors';
  constructor(private apiservice:APIServicesService){}
  
  getlistofProducts(){
    this.apiservice.getProducts();
  }


}
