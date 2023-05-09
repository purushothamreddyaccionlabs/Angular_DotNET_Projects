import { Component, OnInit } from '@angular/core';
import { ActivatedRoute, Route, Router } from '@angular/router';
import { Property } from 'src/app/model/property';
import { HousingService } from 'src/app/services/housing.service';
import {NgxGalleryOptions} from '@kolkov/ngx-gallery';
import {NgxGalleryImage} from '@kolkov/ngx-gallery';
import {NgxGalleryAnimation} from '@kolkov/ngx-gallery';

@Component({
  selector: 'app-property-detail',
  templateUrl: './property-detail.component.html',
  styleUrls: ['./property-detail.component.scss']
})
export class PropertyDetailComponent implements OnInit {

  propertyId: number = 0;
  property = new Property();

  galleryOptions!: NgxGalleryOptions[];
  galleryImages!: NgxGalleryImage[];

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




    this.galleryOptions = [
      {
        width: '100%',
        height: '465px',
        thumbnailsColumns: 4,
        imageAnimation: NgxGalleryAnimation.Slide
      }
    ];

    this.galleryImages = [
      {
        small: 'assets/images/interiorImg1.jpg',
        medium: 'assets/images/interiorImg1.jpg',
        big: 'assets/images/interiorImg1.jpg'
      },
      {
        small: 'assets/images/interiorImg2.jpg',
        medium: 'assets/images/interiorImg2.jpg',
        big: 'assets/images/interiorImg2.jpg'
      },
      {
        small: 'assets/images/interiorImg3.jpg',
        medium: 'assets/images/interiorImg3.jpg',
        big: 'assets/images/interiorImg3.jpg'
      },{
        small: 'assets/images/interiorImg4.jpg',
        medium: 'assets/images/interiorImg4.jpg',
        big: 'assets/images/interiorImg4.jpg'
      },
      {
        small: 'assets/images/interiorImg5.jpg',
        medium: 'assets/images/interiorImg5.jpg',
        big: 'assets/images/interiorImg5.jpg'
      }
    ];
  }


}
