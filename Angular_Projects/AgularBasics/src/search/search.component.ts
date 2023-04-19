import { Component } from '@angular/core';
import { ActivatedRoute } from '@angular/router';

@Component({
  selector: 'app-search',
  templateUrl: './search.component.html',
  styleUrls: ['./search.component.scss']
})
export class SearchComponent {

  constructor(
    private ativatedRoute:ActivatedRoute
  ){
    this.ativatedRoute.queryParams.subscribe(par=>{
      console.log(par);
    })
  }
}
