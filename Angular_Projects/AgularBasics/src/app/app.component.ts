import { Component,ViewChild ,ElementRef} from '@angular/core';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.scss']
})
export class AppComponent {
  title = 'VieswChild';


  // @ViewChild('dobInput') dateOfBirth:any;
  // @ViewChild('dobInput') age:any;
  // @ViewChild(DemoComponent,{static:true}) democom:DemoComponent | undefined;

  // getUserdob(){
  //   console.log(this.dateOfBirth);
  //   console.log(this.age);
  //   let birthdate = new Date(this.dateOfBirth?.nativeElement.value).getFullYear();
  //   console.log(birthdate);
  //   let presentdate = new Date().getFullYear();
  //   console.log(presentdate);
  //   let UserAge = presentdate - birthdate;
  //   this.age.nativeElement.value = UserAge;
  // }
}
