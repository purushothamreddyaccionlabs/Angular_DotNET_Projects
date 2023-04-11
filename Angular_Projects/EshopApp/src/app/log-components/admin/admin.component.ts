import { Component, OnInit } from '@angular/core';
import { FormBuilder, FormGroup, Validators } from '@angular/forms';
import { ToastrService } from 'ngx-toastr';
import { ApiServicesService } from 'src/app/service-API/api-services.service';



@Component({
  selector: 'app-admin',
  templateUrl: './admin.component.html',
  styleUrls: ['./admin.component.scss']
})
export class AdminComponent implements OnInit{
  AllOrdersList:any;
  myGroup:any = FormGroup;
  OrdersStatus = ['Delivered','Dispatched','Canceled','Transit'];
constructor(
  private serviceAPI:ApiServicesService,
  private fb:FormBuilder,
  private toastr:ToastrService
){}
  ngOnInit(){
    this.GetTotalOrders();
   this.myGroup = this.fb.group({
    status:['']
   })
  }
  displayedColumnsList: string[] = ['orderId', 'firstName', 'productName', 'quantity','totalPrice','orderStatus','orderDate','Update'];
  GetTotalOrders(){
    this.serviceAPI.GetTotalOrdersList().subscribe((res)=>{
      this.AllOrdersList = res;
    })
  }


  upadateStatus(element:any){
    var orderstatus = this.myGroup.get('status').value;
    if(orderstatus == ''){
      this.toastr.error("Choose Status Value");
    }else{
      var data ={
        orderId:element.orderId,
        status:orderstatus
      }
      this.serviceAPI.UpdateOrderStatus(data).subscribe((res)=>{
        this.toastr.success("Order Status Updated");
        this.GetTotalOrders();
      })

    }
    

    
  }
 


  logout(){
    this.serviceAPI.logout();
  }
}
