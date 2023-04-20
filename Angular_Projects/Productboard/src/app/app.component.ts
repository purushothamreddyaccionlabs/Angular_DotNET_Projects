import { Component } from '@angular/core';


@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.scss']
})
export class AppComponent {
  title = 'Productboard';
  isDarkTheme = false;

  toggleTheme(){
    this.isDarkTheme = !this.isDarkTheme;
  }
}
