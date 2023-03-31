import { Component, OnInit } from '@angular/core';
import { ToastrService } from 'ngx-toastr';
import { ApiServicesService } from 'src/app/service-API/api-services.service';

@Component({
  selector: 'app-cart',
  templateUrl: './cart.component.html',
  styleUrls: ['./cart.component.scss']
})
export class CartComponent implements OnInit{

  constructor(
    private apiservice:ApiServicesService,
    private toastr:ToastrService
  ){}

  allCartItems:any;
  userdata:any;

  ngOnInit(): void {
    const sessionData = sessionStorage.getItem('token');
    this.userdata = JSON.parse(sessionData|| '{}');
    console.log(this.userdata);
    this. GetListofItems();
  }

  GetListofItems(){
    var id = parseInt(this.userdata.id);
    this.apiservice.getCartItemsbyuserId(id).subscribe((response)=>{
      console.log(response);
      this.allCartItems = response;
    })
  }
  
  delterItem(id:any){
    this.apiservice.DeletecartItem(id).subscribe((res)=>{
      this.GetListofItems();
      this.toastr.success("Item Deleted");
    })
  }
}
