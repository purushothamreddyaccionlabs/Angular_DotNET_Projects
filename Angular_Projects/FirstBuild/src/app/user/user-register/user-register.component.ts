import { Component, OnInit } from '@angular/core';
import { AbstractControl, FormBuilder, FormControl, FormGroup, ValidationErrors, ValidatorFn, Validators } from '@angular/forms';
import { UserServiceService } from 'src/app/services/user-service.service';

@Component({
  selector: 'app-user-register',
  templateUrl: './user-register.component.html',
  styleUrls: ['./user-register.component.scss']
})
export class UserRegisterComponent implements OnInit {

  registrationForm: any = FormGroup;
  user:any = {};
  userSubmitted!:boolean;

  passwordMatchingValidator: ValidatorFn = (control: AbstractControl): ValidationErrors | null => {
    const password = control.get('password');
    const confirmPassword = control.get('confirmPassword');
    return password && confirmPassword && password.value !== confirmPassword.value ? { notmatched: true } : null;
  };
  constructor(private fb: FormBuilder,private userService:UserServiceService) { }

  ngOnInit() {
    this.createRegistrationForm();
  }

  createRegistrationForm() {
    this.registrationForm = this.fb.group({
      userName: ['', Validators.required],
      email: ['', [Validators.required, Validators.email]],
      password: ['', [Validators.required, Validators.minLength(8)]],
      confirmPassword: ['', [Validators.required]],
      mobile: ['', [Validators.required, Validators.maxLength(10)]]
    }, { Validators: this.passwordMatchingValidator });
  }
  //------------------------------------
  //Getter methods for all form controls
  //------------------------------------
  get userName() {
    return this.registrationForm.get('userName') as FormControl;
  }

  get email() {
    return this.registrationForm.get('email') as FormControl;
  }

  get password() {
    return this.registrationForm.get('password') as FormControl;
  }

  get confirmPassword() {
    return this.registrationForm.get('confirmPassword') as FormControl;
  }

  get mobile() {
    return this.registrationForm.get('mobile') as FormControl;
  }
  //----------------------------------------

  onSubmit() {
    console.log(this.registrationForm);
    this.userSubmitted = true;
    if(this.registrationForm.valid){
      this.user = Object.assign(this.user,this.registrationForm.value);
      this.userService.addUser(this.user);
      this.registrationForm.reset();
    }

  }


}
