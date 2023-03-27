import { Component } from '@angular/core';
import { ApiServicesService } from 'src/app/service-API/api-services.service';


@Component({
  selector: 'app-header',
  templateUrl: './header.component.html',
  styleUrls: ['./header.component.scss']
})
export class HeaderComponent {

constructor(
  private apiservices:ApiServicesService
){}
  logout(){
    this.apiservices.logout();
  }

}
