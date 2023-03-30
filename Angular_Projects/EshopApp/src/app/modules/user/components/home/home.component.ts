import { Component, OnInit } from '@angular/core';
import { ApiServicesService } from 'src/app/service-API/api-services.service';
import { MatDialogModule } from '@angular/material/dialog';
import { MatDialog, MAT_DIALOG_DATA, MatDialogRef } from '@angular/material/dialog';
import { DialogboxComponent } from '../dialogbox/dialogbox.component';


@Component({
  selector: 'app-home',
  templateUrl: './home.component.html',
  styleUrls: ['./home.component.scss']
})
export class HomeComponent implements OnInit{
  //Image slider
  imageObject: Array<object> = [{
    image: 'https://c0.wallpaperflare.com/preview/378/243/705/ecommerce-internet-marketing-online.jpg',
    thumbImage: 'https://c0.wallpaperflare.com/preview/378/243/705/ecommerce-internet-marketing-online.jpg',
    alt: 'Image alt'
  }, {
    image: '../../../../../assets/Images/51ovs76vmtL._SX3000_.jpg',
    thumbImage: '../../../../../assets/Images/51ovs76vmtL._SX3000_.jpg',
    alt: 'Image alt',
    order: 1
  },
  {
    image: '../../../../../assets/Images/books.jpg',
    thumbImage: '../../../../../assets/Images/books.jpg',
    alt: 'Image alt'
  },
  {
    image: '../../../../../assets/Images/Electronics-keyboard.jpg',
    thumbImage: '../../../../../assets/Images/Electronics-keyboard.jpg',
    alt: 'Image alt'
  },
  {
    image: '../../../../../assets/Images/Electronics-mouse.jpg',
    thumbImage: '../../../../../assets/Images/Electronics-mouse.jpg',
    alt: 'Image alt'
  },
  {
    image: '../../../../../assets/Images/Hp.jpg',
    thumbImage: '../../../../../assets/Images/Hp.jpg',
    alt: 'Image alt'
  },
  {
    image: '../../../../../assets/Images/Lenovo.jpg',
    thumbImage: '../../../../../assets/Images/Lenovo.jpg',
    alt: 'Image alt'
  },
  {
    image: '../../../../../assets/Images/watch.jpg',
    thumbImage: '../../../../../assets/Images/watch.jpg',
    alt: 'Image alt'
  },
  
  {
    image: '../../../../../assets/Images/allu-Arjun.jpg',
    thumbImage: '../../../../../assets/Images/allu-Arjun.jpg',
    alt: 'Image alt'
  }
  ];

  //list of products
  AllProductsList:any;

  constructor(
    private serviceapi:ApiServicesService,
    private dialog:MatDialog
  ){}
  ngOnInit(){
    this.DisplayData();
  }

//Display all products in the home page
  DisplayData(){
    this.serviceapi.allProductsList().subscribe((res)=>{
      this.AllProductsList = res;
      console.log(res);
    });

  }

  getProductsByCategory(i:number){
   
    this.serviceapi.productsListbyCategoryId(i).subscribe((response)=>{
      this.AllProductsList = response;
      console.log(response);
  
    })
  }
  getAllProducts(){
    this.DisplayData();
  }
  
  //open dialogbox
  openProductDialogbox(item:any){
    let dialogRef = this.dialog.open(DialogboxComponent,{
      width:'60%',
      height:'90%',
      data:item
    })
  }


}
