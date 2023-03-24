import { Component, OnInit } from '@angular/core';
import { ActivatedRoute } from '@angular/router';
import { Room, RoomList } from '../rooms';

@Component({
  selector: 'app-rooms',
  templateUrl: './rooms.component.html',
  styleUrls: ['./rooms.component.scss']
})
export class RoomsComponent{

constructor(private activatedRouter:ActivatedRoute){
  this.activatedRouter.queryParams.subscribe(param=>{
    console.log(param);

  })
}

title = 'hotelinventoryapp';
hotelName = "Taj Hotels";
numberofrooms = 90;
hiderooms = true;
role = "Admin";



toggle() {
this.hiderooms = !this.hiderooms;
}



rooms: Room = {
    totalRooms: 20,
    availableRooms: 24,
    bookedRooms: 5
}

roomList:RoomList[] = [{
  roomNumber:1,
  roomType:"Delux Room",
  amenities:"Air conditionar, free wi-fi, Tv, Bathroom, kitchen",
  price:500,
  photos:"Images",
  checkinTime: new Date('11-nov-2021'),
  checkoutTime:new Date('12-nov-2021')
},{
  roomNumber:2,
  roomType:"Delux Room",
  amenities:"Air conditionar, free wi-fi, Tv, Bathroom, kitchen",
  price:10000,
  photos:"Images",
  checkinTime: new Date('11-nov-2021'),
  checkoutTime:new Date('12-nov-2021')

},{
  roomNumber:3,
  roomType:"Delux Room",
  amenities:"Air conditionar, free wi-fi, Tv, Bathroom, kitchen",
  price:15000,
  photos:"Images",
  checkinTime: new Date('11-nov-2021'),
  checkoutTime:new Date('12-nov-2021')

}];
}
