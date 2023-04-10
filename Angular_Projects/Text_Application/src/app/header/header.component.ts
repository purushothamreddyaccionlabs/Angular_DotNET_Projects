import { Component, EventEmitter, Input, Output } from '@angular/core';

@Component({
  selector: 'app-header',
  templateUrl: './header.component.html',
  styleUrls: ['./header.component.scss']
})
export class HeaderComponent {


msg1 = "Purushotham";
msg2 = "MOLAKAVARIPALLI";
msg3 = "andhra pradesh";

group ={
  name:"hari",
  lastname:"c"
}

cDate = new Date();


}


