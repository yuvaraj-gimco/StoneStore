import { Component, OnInit, AfterViewInit } from '@angular/core';

import { AuthService } from '../_services/auth.service';
import { Router } from '@angular/router';



@Component({
    selector: 'app-login',
    templateUrl: './login.component.html',
    styleUrls: ['./login.component.css']
})
export class LoginComponent implements OnInit, AfterViewInit {
    model: any = { };
    constructor(private authServices: AuthService, private router: Router  ) {}

    ngOnInit() {}

    ngAfterViewInit() {
        /*$(function() {
            $(".preloader").fadeOut();
        });

        $('#to-recover').on("click", function() {
            $("#loginform").slideUp();
            $("#recoverform").fadeIn();
        });*/
    }

    onLoggedin() {
        // localStorage.setItem('isLoggedin', 'true');
        console.log(this.model);
        this.authServices.login(this.model).subscribe(data => {
            console.log('succesfully logged');
            this.router.navigate(['/starter']);
        }, error => {

            console.log('failed to login');
        }
        );
    }

}
