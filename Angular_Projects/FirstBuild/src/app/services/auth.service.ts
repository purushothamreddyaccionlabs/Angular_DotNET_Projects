import { Injectable } from "@angular/core";

@Injectable({
  providedIn:'root'
})
export class AuthService{
  constructor(){}
  authUser(user:any){
    let UserArray = [];
    if(localStorage.getItem('User')){
      UserArray = JSON.parse(localStorage.getItem('User')||'')
    }
    return UserArray.find((p: { userName: string; password: string; }) => p.userName === user.userName && p.password === user.password);
  }
}
