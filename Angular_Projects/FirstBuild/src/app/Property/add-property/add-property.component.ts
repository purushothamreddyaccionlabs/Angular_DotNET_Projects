import { Component, ViewChild } from '@angular/core';
import { NgForm } from '@angular/forms';
import { Router } from '@angular/router';
import { TabsetComponent } from 'ngx-bootstrap/tabs/public_api';
import { IPropertyBase } from 'src/app/model/ipropertybase';







@Component({
  selector: 'app-add-property',
  templateUrl: './add-property.component.html',
  styleUrls: ['./add-property.component.scss']
})
export class AddPropertyComponent {

  // @ViewChild('From') addPropertyForm:NgForm;
  @ViewChild('formTabs') formTabs!: TabsetComponent;

  propertyTypes:Array<string>=['House','Apartment','Duplex'];
  furnishType:Array<string> = ['Fully','Semi','Unfurnished'];
  propertyFaces:Array<string> = ['East','West','South','North'];
  propertyView: IPropertyBase= {
    Id: 0,
    Name: '',
    Price: 0,
    SellRent:0,
    PType: '',
    FType:'',
    BHK:0,
    BuiltArea:0,
    City:'',
    RTM:0
  };
;

  constructor(private router: Router) { }
  onBack() {
    this.router.navigate(['/']);
  }

  onSubmit(Form:NgForm){
    console.log("success");
    console.log(Form);
  }

  selectTab(tabId: number) {
      this.formTabs.tabs[tabId].active = true;
  }

}
