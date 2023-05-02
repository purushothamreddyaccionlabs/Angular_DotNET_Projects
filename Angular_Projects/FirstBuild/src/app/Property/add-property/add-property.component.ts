import { Component, ViewChild } from '@angular/core';
import { NgForm } from '@angular/forms';
import { Router } from '@angular/router';

@Component({
  selector: 'app-add-property',
  templateUrl: './add-property.component.html',
  styleUrls: ['./add-property.component.scss']
})
export class AddPropertyComponent {

  // @ViewChild('From') addPropertyForm:NgForm;

  constructor(private router: Router) { }
  onBack() {
    this.router.navigate(['/']);
  }

  onSubmit(Form:NgForm){
    console.log("success");
    console.log(Form);
  }
}
