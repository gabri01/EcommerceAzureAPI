import { Injectable } from '@angular/core';
import { HttpClient, HttpHeaders } from '@angular/common/http';

@Injectable({
  providedIn: 'root'
})
export class UserService {
  apiRootPath = 'https://localhost:7287';

  constructor(private httpClient: HttpClient) { };

    //LOGIN
    loginUser(auth:any){
      const url = this.apiRootPath + `/api/Utente/Login`
      return this.httpClient.post(url, auth, { responseType: "text" });
    }

    setUser(token: any) {
      localStorage.setItem('token', token);
    }
    
    isLoggedIn() {
      return localStorage.getItem('token') ? true : false;
    }
    
    logoutUser() {
      localStorage.removeItem('token');
    }
}
