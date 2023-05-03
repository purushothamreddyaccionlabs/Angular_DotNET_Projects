import { Injectable } from '@angular/core';
import { User } from '../model/user';

@Injectable({
  providedIn: 'root'
})
export class UserServiceService {

  constructor() { }

  addUser(user: User){
    let users: any[] = [];
    if(localStorage.getItem('User')){
      users = JSON.parse(localStorage.getItem('User')|| '');
      users = [user,...users]
    }else{
      users = [user]
    }
    localStorage.setItem('User',JSON.stringify(users));
  }
}
