import { Component } from '@angular/core';
import { Router } from '@angular/router';
import { UserService } from 'src/app/services/user.service';
@Component({
  selector: 'app-navbar',
  templateUrl: './navbar.component.html',
  styleUrls: ['./navbar.component.css'],
})
export class NavbarComponent {
  constructor(private router: Router, private userService: UserService) {}

  sign() {
    this.router.navigate(['sign']);
  }

  ordini() {
    this.router.navigate(['../','ordini']);
  }

  login() {
    this.router.navigate(['login']);
  }

  isLoggedIn() {
    return localStorage.getItem('token') ? true : false;
  }

  LogoutUser() {
    this.router.navigate(['../', 'login']);
    this.userService.logoutUser();
  }
}
