import { Component } from '@angular/core';


@Component({
  selector: 'app-home',
  templateUrl: './home.component.html',
  styleUrls: ['./home.component.scss']
})
export class HomeComponent {
  imageObject : Array<object> = [{
    image: 'https://c0.wallpaperflare.com/preview/378/243/705/ecommerce-internet-marketing-online.jpg',
    thumbImage: 'https://c0.wallpaperflare.com/preview/378/243/705/ecommerce-internet-marketing-online.jpg',
    alt:'Image alt'
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
}
];


}
