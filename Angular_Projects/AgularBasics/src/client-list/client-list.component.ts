import { Component } from '@angular/core';

@Component({
  selector: 'app-client-list',
  templateUrl: './client-list.component.html',
  styleUrls: ['./client-list.component.scss']
})
export class ClientListComponent {


  clientList = [
    { clientId: 10, firstname: 'Ravi', lastname: 'Naik' },
    { clientId: 12, firstname: 'Phani', lastname: 'kumar' },
    { clientId: 13, firstname: 'Sharma', lastname: 'Das' },
    { clientId: 14, firstname: 'Kiran', lastname: 'Raj' },
    { clientId: 16, firstname: 'Pawan', lastname: 'kumar' },
    { clientId: 17, firstname: 'Mahesh', lastname: 'Babu' }

  ]
}
