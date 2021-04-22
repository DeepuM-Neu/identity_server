import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-home',
  templateUrl: './home.component.html',
  styleUrls: ['./home.component.css']
})
export class HomeComponent implements OnInit {

  constructor() { }

  ngOnInit(): void {
  }

  goToLink() {
    window.open("https://web-dev.env.pricespeoplepay.com.au/pairs-login", 'myWindow');
  }

}
