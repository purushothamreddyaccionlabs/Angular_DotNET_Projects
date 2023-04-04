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

  //Register users data
  registerdata(data:any){
    return this.http.post(this.url+ "/api/Users/Register",data);
  }

  //List of Products
  allProductsList(){
    return this.http.get(this.url + "/api/Products/GetProducts");
  }

  //List of products based on categoryId
  productsListbyCategoryId(i:any){
    return this.http.get(this.url + "/api/Products/GetProductsByCategoryId"+i);
  }

  //Add products to cart
  addProductsToCart(data:any){
    return this.http.post(this.url + "/api/Cart/AddToCart",data);
  }

  //Get cart items by userId
  getCartItemsbyuserId(num:any){
    return this.http.get(this.url + "/api/Cart/GetProductsBy" + num);
  }

  //get product by productid
  getProductbyProductID(num:any){
    return this.http.get(this.url + "/api/Products/GetProductById"+num);
  }

  //Delete products in cart table
  DeletecartItem(num:any){
    return this.http.delete(this.url + "/api/Cart/DeleteProductbyCartId" + num);
  }


  isLoggedIn(){

    var sessionData = sessionStorage.getItem('token');
    if(sessionData !==null){
      return true;
    }else{
      return false;
    }
  }

  //Checking user details valid or not
login(data:any){
   this.validateUser(data).subscribe((res) => { 
    sessionStorage.setItem('token', JSON.stringify(res));
    this.router.navigate(['/user']);
  })
  }

  //For logout user
  logout(){
    sessionStorage.removeItem('token');
    this.router.navigate(['/login']);
  }

}
