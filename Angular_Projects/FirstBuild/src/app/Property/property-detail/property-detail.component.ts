import { Component, OnInit } from '@angular/core';
import { ActivatedRoute, Route, Router } from '@angular/router';
import { Property } from 'src/app/model/property';
import { HousingService } from 'src/app/services/housing.service';

@Component({
  selector: 'app-property-detail',
  templateUrl: './property-detail.component.html',
  styleUrls: ['./property-detail.component.scss']
})
export class PropertyDetailComponent implements OnInit {

  propertyId: number = 0;
  property = new Property();

  constructor(
    private activatedRoute: ActivatedRoute,
    private router: Router,
    private housingService: HousingService
  ) { }

  ngOnInit() {
    this.propertyId = +this.activatedRoute.snapshot.params['id'];

    this.activatedRoute.data.subscribe(
      (data)=>{
        this.property = data['prp'];
      }
    )

    // this.activatedRoute.params.subscribe(
    //   (params) => {
    //     this.propertyId = +params['id'];
    //     this.housingService.getProperty(this.propertyId).subscribe(
    //       (data:any) =>{
    //         this.property = data;
    //       },error => this.router.navigate(['/'])
    //     );
    //   })
  }


}
