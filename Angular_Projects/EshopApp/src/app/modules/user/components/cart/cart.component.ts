import { Component, OnInit, ɵsetAllowDuplicateNgModuleIdsForTest } from '@angular/core';
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

  allCartItems:any=[];
  userdata:any;
  totalPrice = 0;
  totalItems = 0;
 

  ngOnInit(): void {
    const sessionData = sessionStorage.getItem('token');
    this.userdata = JSON.parse(sessionData|| '{}');
    console.log(this.userdata);
    this. GetListofItems();
    this.getTotalpriceandlen();
  }

  GetListofItems(){
    var id = parseInt(this.userdata.id);
    this.apiservice.getCartItemsbyuserId(id).subscribe((response)=>{
      console.log(response);
      this.allCartItems = response;
      this.getTotalpriceandlen();
    })
  }

  delterItem(id:any){
    this.apiservice.DeletecartItem(id).subscribe((res)=>{
      this.GetListofItems();
      this.getTotalpriceandlen();
      this.toastr.success("Item Deleted");
    })
  }
  
  getTotalpriceandlen(){
    this.totalItems = this.allCartItems.length;
    for (let index = 0; index <= this.allCartItems.length; index++) {
        const element = this.allCartItems[index];
      this.totalPrice = this.totalPrice + element.totalPrice;
    }
  }
  


}
