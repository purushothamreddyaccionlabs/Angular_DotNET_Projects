import { Component, OnInit } from '@angular/core';
import { NgForm } from '@angular/forms';
import { ActivatedRoute } from '@angular/router';

@Component({
  selector: 'app-search',
  templateUrl: './search.component.html',
  styleUrls: ['./search.component.scss']
})
export class SearchComponent implements OnInit{

  firstname:string = '';
  terms:boolean = false;
  customerType:string ='';
  description:string = '';
  constructor(
    private ativatedRoute:ActivatedRoute
  ){ }
  ngOnInit() {
    
  }

  

  submitform(formValue:NgForm){
    console.log(formValue.value);
  }

  resetForm(custForm:NgForm){
    //custForm.reset();
    custForm.resetForm();
  }
  setvaluesByTemform(formsData:NgForm){

    let formdata = {
      firstname:'Ram charan Reddy Angullu',
      terms:true,
      customerType:'2',
      description:'This is set by value method'
    }

    formsData.setValue(formdata);
  }
 
}
