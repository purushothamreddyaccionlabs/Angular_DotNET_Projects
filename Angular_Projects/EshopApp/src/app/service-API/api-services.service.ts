import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Router } from '@angular/router';


@Injectable({
  providedIn: 'root'
})
export class ApiServicesService {

  constructor(
    private http:HttpClient,
    private router:Router
  ) { }
 
  url = "https://localhost:7103";

   //Validating the user
   validateUser(data:any){
    return this.http.post(this.url + "/api/Users/ValidateUser",data);
  }

  isLoggedIn(){
    var sessionData = sessionStorage.getItem('token');
    if(sessionData !==null){
      return true;
    }else{
      return false;
    }
  }

login(data:any){
   this.validateUser(data).subscribe((res) => { 
    sessionStorage.setItem('token', JSON.stringify(res));
    this.router.navigate(['/user']);
    // console.log(responseData);
  })
  }

  logout(){
    sessionStorage.removeItem('token');
    this.router.navigate(['/login']);
  }








}
