
import { Component,OnInit } from '@angular/core';
import { NgForm } from '@angular/forms';
import { SignInData } from '../model/signInDetails';
import { AuthenticationService } from '../service/authentication/authentication.service';


@Component({
  selector: 'app-login',
  templateUrl: './login.component.html',
  styleUrls: ['./login.component.css']
})
export class LoginComponent implements OnInit{

  isFormInvalid = false;
  areCredentialsInvalid = true;

  constructor(private authenticationService:AuthenticationService){}
ngOnInit():void{}

onSubmit(signInForm:NgForm){
  if(!this.isFormInvalid){
    this.isFormInvalid = true;
    this.areCredentialsInvalid = false;
    return;
  }

  this.checkCredentials(signInForm);

  
  
}

private checkCredentials(signInForm:NgForm){
  var signInData:any = new SignInData(signInForm.value.email,signInForm.value.password);
  if(!this.authenticationService.authenticate(signInData)){
    this.isFormInvalid = false;
    this.areCredentialsInvalid = true;
  }
}

}
