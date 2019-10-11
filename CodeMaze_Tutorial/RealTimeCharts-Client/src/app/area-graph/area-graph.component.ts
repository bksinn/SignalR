import { Component, OnInit, Input, Output, EventEmitter } from '@angular/core';
import * as shape from 'd3-shape';
import { brushX, brush, brushY } from 'd3-brush';
import { IAffiliateSubmission } from '../_interfaces/affiliatesubmission.model';
import { ViewDimensions } from '@swimlane/ngx-charts';

@Component({
  selector: 'app-area-graph',
  templateUrl: './area-graph.component.html',
  styleUrls: ['./area-graph.component.css']
})
export class AreaGraphComponent implements OnInit {
  single: any[];
  multi: IAffiliateSubmission[];

  view: any[] = [700, 400];

  // options
  showXAxis = true;
  showYAxis = true;
  gradient = false;
  showLegend = true;
  showXAxisLabel = true;
  showYAxisLabel = true;
  xAxisLabel = 'Time (hours)';
  yAxisLabel = 'Amount';
  curve = shape.curveNatural;
  //colorScheme = "cool"; //Using preset color scheme https://github.com/swimlane/ngx-charts/blob/master/src/utils/color-sets.ts
  colorScheme = {
    domain: ['#37139E', '#0ABEE3', '#FECB58', '#991046']
  };

  // line, area
  autoScale = true;
  
  constructor() {
    function generateSubmitted() {
      let arr = [];
      for (var i = 0; i < 25; i+=1) {
        arr.push({
          "name": i.toString() + ":00",
          "value": (1 + Math.random()) * 1.25
        });
      }
      return arr;
    }
    function generateDecline() {
      let arr = [];
      for (var i = 0; i < 25; i+=1) {
        arr.push({
          "name": i.toString() + ":00",
          "value": (1 + Math.random())
        });
      }
      return arr;
    }
    function generateFiltered() {
      let arr = [];
      for (var i = 0; i < 25; i+=1) {
        arr.push({
          "name": i.toString() + ":00",
          "value": (1 + Math.random())s
        });
      }
      return arr;
    }
    function generateThrottled() {
      let arr = [];
      for (var i = 0; i < 25; i+=1) {
        arr.push({
          "name": i.toString() + ":00",
          "value": Math.random() * 0.1
        });
      }
      return arr;
    }
    
    //Mock data
    this.multi = [
      {
        "name": "submitted",
        "series": generateSubmitted() //returns array of objects
      }
    ];

    Object.assign(this.multi)   
    //Object.assign(this, { multi })   

  }
  
  onSelect(event) {
    console.log(event);
  }

  ngOnInit() {
    this.addBrush();
  }

  addBrush() {
    var brush = brushX();
    console.log(document.getElementsByTagName("svg")[0]);
  }

}

export var single = [
  {
    "name": "affiliate1",
    "value": 8940000
  },
  {
    "name": "affiliate12",
    "value": 5000000
  },
  {
    "name": "affiliate13",
    "value": 7200000
  }
];

export var multi = [
  {
    "name": "affiliate1",
    "series": [
      {
        "name": "2010",
        "value": 7300000
      },
      {
        "name": "2011",
        "value": 8940000
      }
    ]
  },

  {
    "name": "affiliate12",
    "series": [
      {
        "name": "2010",
        "value": 7870000
      },
      {
        "name": "2011",
        "value": 8270000
      }
    ]
  },

  {
    "name": "affiliate13",
    "series": [
      {
        "name": "2010",
        "value": 5000002
      },
      {
        "name": "2011",
        "value": 5800000
      }
    ]
  }
];
