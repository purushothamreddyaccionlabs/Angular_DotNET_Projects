import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { MasterComponent } from './master/master.component';
import { StudentComponent } from './student/student.component';

const routes: Routes = [
  {path: 'master',component:MasterComponent},
  {path:'student',component:StudentComponent}
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
export const componentsList = [
  MasterComponent,
  StudentComponent
];
