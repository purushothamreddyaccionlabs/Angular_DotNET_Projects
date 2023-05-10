import { Injectable } from "@angular/core";

@Injectable({
  providedIn:'root'
})
export class AuthService{
  constructor(){}
  authUser(user:any){
    let userArray = [];
    if(localStorage.getItem('User')){
      userArray = JSON.parse(localStorage.getItem('User')||'')
    }
    return userArray.find((p:any) => p.userName === user.userName && p.password === user.password);
  }
}
