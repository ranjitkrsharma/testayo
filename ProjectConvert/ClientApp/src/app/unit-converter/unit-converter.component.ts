import { Component } from '@angular/core';
import { NgForm, FormBuilder, FormGroup, Validators, FormControl } from '@angular/forms';
import { Router, ActivatedRoute } from '@angular/router';

@Component({
    selector: 'app-unit-converter',
    templateUrl: './unit-converter.component.html',
    styleUrls: ['./unit-converter.component.scss']
})
export class UnitConverterComponent {

  coversionForm: FormGroup;
  OutputValue;
  constructor(private formBuilder: FormBuilder, private router: Router) {
    this.coversionForm = this.formBuilder.group({
      conversionvalue: ['', Validators.required],
      conversionfrom: ['kg', Validators.required],
      conversionto: ['pound', Validators.required]
    }); }

  

  onClickSubmit() {
    this.OutputValue = "value";
    alert("Entered Email id : ");

    if (!this.coversionForm.valid) {
      return;
    }

 
  }

  cancel() {
    this.router.navigate(['/unit-converter']);
  }
}
