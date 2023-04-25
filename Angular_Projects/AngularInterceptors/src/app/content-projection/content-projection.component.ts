import { Component, ContentChild, TemplateRef } from '@angular/core';

@Component({
  selector: 'app-content-projection',
  templateUrl: './content-projection.component.html',
  styleUrls: ['./content-projection.component.scss']
})
export class ContentProjectionComponent {

  @ContentChild('admin') adminTemplate!: TemplateRef<any>;

}
