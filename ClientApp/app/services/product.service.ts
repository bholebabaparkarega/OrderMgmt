import { Injectable } from '@angular/core';
import { Http } from '@angular/http';
import { Observable } from 'rxjs/Observable'
import 'rxjs/Rx';
@Injectable()
export class ProductService
{
    constructor(private _http: Http)
    {

    }
    public getAll = (): Observable<Product[]> =>
    {
        return this._http.get("/api/product").map(data => data.json());
    }

}