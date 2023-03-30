import { Component, Inject, OnInit } from '@angular/core';
import { MatDialogModule } from '@angular/material/dialog';
import { MatDialog, MAT_DIALOG_DATA, MatDialogRef } from '@angular/material/dialog';
import { ApiServicesService } from 'src/app/service-API/api-services.service';
import { ToastrService } from 'ngx-toastr';

@Component({
  selector: 'app-dialogbox',
  templateUrl: './dialogbox.component.html',
  styleUrls: ['./dialogbox.component.scss']
})
export class DialogboxComponent implements OnInit{

cartSize = 1; 
userdata:any;

  constructor(
    public dialogRef:MatDialogRef<DialogboxComponent>,
    @Inject(MAT_DIALOG_DATA) public data:any=[],
    private serviceapi:ApiServicesService,
    private toaster:ToastrService
    ){}

    ngOnInit(){
      const sessionData = sessionStorage.getItem('token');
      this.userdata = JSON.parse(sessionData|| '{}');

    }

    productInfo = this.data;

    
  
   
    //close dash board
    backtohome(){
      this.dialogRef.close();
    }

    

    addProductsToCart(){
      var totalAmout = (this.productInfo.unitPrice -  this.productInfo.discount)*this.cartSize;
      var data = {
        userId:this.userdata.id,
        product:this.productInfo.productName,
        productId:this.productInfo.id,
        unitPrice:this.productInfo.unitPrice,
        discount:this.productInfo.discount,
        quantity:this.cartSize,
        totalPrice:totalAmout
      }
      this.serviceapi.addProductsToCart(data).subscribe((res)=>{
        console.log(res);
        this.toaster.success("Item added to your cart");
      })
     
    }

    
}
