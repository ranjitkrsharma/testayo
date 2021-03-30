import { Component, Inject } from '@angular/core';
import { NgForm, FormBuilder, FormGroup, Validators, FormControl } from '@angular/forms';
import { Router, ActivatedRoute } from '@angular/router';
import { HttpClient } from '@angular/common/http';

@Component({
    selector: 'app-lengthconvertor',
    templateUrl: './lengthconvertor.component.html',
    styleUrls: ['./lengthconvertor.component.scss']
})
/** lengthconvertor component*/
export class LengthconvertorComponent {
    /** lengthconvertor ctor */
  coversionForm: FormGroup;
  OutputValue;
  httpclient: HttpClient;
  baseUrl: string;
  constructor(private formBuilder: FormBuilder, private router: Router, http: HttpClient, @Inject('BASE_URL') baseUrl: string) {
    this.coversionForm = this.formBuilder.group({
      conversionvalue: ['', Validators.required],
      conversionfrom: ['km', Validators.required],
      conversionto: ['mile', Validators.required]
    });
    this.httpclient = http;
    this.baseUrl = baseUrl;
  }

  onClickSubmit() {

    if (!this.coversionForm.valid) {
      return;
    }

    this.httpclient.get<string[]>(this.baseUrl + 'api/length/' + this.coversionForm.controls['conversionvalue'].value + '/' + this.coversionForm.controls['conversionto'].value).subscribe(result => {
      this.OutputValue = result[1];
    }, error => console.error(error));


  }

  cancel() {
    this.router.navigate(['/length-convert']);
  }
}
