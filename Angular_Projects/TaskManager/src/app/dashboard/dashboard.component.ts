import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-dashboard',
  templateUrl: './dashboard.component.html',
  styleUrls: ['./dashboard.component.scss']
})
export class DashboardComponent implements OnInit{
  
  Designation!: string;
  Username!:string;
  NoOfTeamMembers!: number;
  TotalCostOfAllProjects!: number;
  PendingTasks!: number;
  UpComingProjects!: number;
  ProjectCost!: number;
  CurrentExpenditure!: number;
  AvailbleFunds!: number;
  
  
  ngOnInit() {
   this.Designation = "Team Leader";
   this.Username = "John Smith";
   this.NoOfTeamMembers = 67;
   this.TotalCostOfAllProjects = 240;
   this.PendingTasks = 12;
   this.UpComingProjects = 3;
   this.ProjectCost = 9776783;
   this.CurrentExpenditure = 87432;
   this.AvailbleFunds = 764573;
  }

}
