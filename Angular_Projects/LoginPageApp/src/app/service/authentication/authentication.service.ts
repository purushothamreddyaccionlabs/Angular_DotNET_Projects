import { Injectable } from '@angular/core';
import { Router } from '@angular/router';
import { SignInData } from 'src/app/model/signInDetails';

@Injectable({
  providedIn: 'root'
})
export class AuthenticationService {

  private readonly morkedUser = new SignInData('john@gmail.com','test123');

  isAthenticated = false;

  constructor(private router:Router) { }

  authenticate(signInData:SignInData):boolean{

    if(this.checkCredential(signInData)){
      this.isAthenticated = true;
      this.router.navigate(['home']);
      return true;
    }
    this.isAthenticated = false;
    return false;
  }

  private checkCredential(signInData:SignInData):boolean{
    return this.checkEmail(signInData.getEmail()) && this.checkPassword(signInData.getPassword());
  }

  private checkEmail(email:string):boolean{
    return email === this.morkedUser.getEmail();
  }

  private checkPassword(password:string):boolean{
    return password === this.morkedUser.getPassword();
  }

  logout(){
    this.isAthenticated = false;
    this.router.navigate(['']);
  }

}
