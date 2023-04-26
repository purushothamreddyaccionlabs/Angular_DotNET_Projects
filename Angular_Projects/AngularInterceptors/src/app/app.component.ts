import { AfterViewInit, Component, ElementRef, ViewChild } from '@angular/core';
import { APIServicesService } from './apiservices.service';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.scss']
})
export class AppComponent implements AfterViewInit{
  title = 'AngularInterceptors';
  constructor(private apiservice:APIServicesService){}
 
  
  getlistofProducts(){
    this.apiservice.getProducts();
  }
  
  @ViewChild('headline')headline?:ElementRef;

  ngAfterViewInit(): void {
    console.log(this.headline?.nativeElement.InnerHTML);
  }


}
