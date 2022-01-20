
/* Smart UI v12.0.0 (2022-01-16) 
Copyright (c) 2011-2021 jQWidgets. 
License: https://htmlelements.com/license/ */ //

Smart.Chart&&(Smart.Chart.prototype._moduleApi=!0,Smart.Chart.prototype.getItemsCount=function(t,e){const r=this.seriesGroups[t];if(!this._isSerieVisible(t,e))return 0;const i=this._renderData;return!r||!i||i.length<=t?0:r.series[e]?i[t].offsets[e].length:0},Smart.Chart.prototype.getXAxisRect=function(t){const e=this._renderData;if(e&&!(e.length<=t)&&e[t].xAxis)return e[t].xAxis.rect},Smart.Chart.prototype.getXAxisLabels=function(t){const e=[];let r=this._renderData;if(!r||r.length<=t)return e;if(r=r[t].xAxis,!r)return e;const i=this.seriesGroups[t];if(i.polar||i.spider){for(let t=0;t<r.polarLabels.length;t++){const i=r.polarLabels[t];e.push({offset:{x:i.x,y:i.y},value:i.value})}return e}const s=this._getXAxis(t),o=this.getXAxisRect(t),a="top"===s.position||"right"===s.position,n="horizontal"===i.orientation;for(let t=0;t<r.data.length;t++)n?e.push({offset:{x:o.x+(a?0:o.width),y:o.y+r.data.data[t]},value:r.data.xvalues[t]}):e.push({offset:{x:o.x+r.data.data[t],y:o.y+(a?o.height:0)},value:r.data.xvalues[t]});return e},Smart.Chart.prototype.getValueAxisRect=function(t){const e=this._renderData;if(e&&!(e.length<=t)&&e[t].valueAxis)return e[t].valueAxis.rect},Smart.Chart.prototype.getValueAxisLabels=function(t){const e=[];let r=this._renderData;if(!r||r.length<=t)return e;if(r=r[t].valueAxis,!r)return e;const i=this._getValueAxis(t),s="top"===i.position||"right"===i.position,o=this.seriesGroups[t],a="horizontal"===o.orientation;if(o.polar||o.spider){for(let t=0;t<r.polarLabels.length;t++){const i=r.polarLabels[t];e.push({offset:{x:i.x,y:i.y},value:i.value})}return e}for(let t=0;t<r.items.length;t++)a?e.push({offset:{x:r.itemOffsets[r.items[t]].x+r.itemWidth/2,y:r.rect.y+(s?r.rect.height:0)},value:r.items[t]}):e.push({offset:{x:r.rect.x+r.rect.width,y:r.itemOffsets[r.items[t]].y+r.itemWidth/2},value:r.items[t]});return e},Smart.Chart.prototype.getPlotAreaRect=function(){return this._plotRect},Smart.Chart.prototype.getRect=function(){return this._rect},Smart.Chart.prototype.showToolTip=function(t,e,r,i,s){const o=this.getItemCoord(t,e,r);isNaN(o.x)||isNaN(o.y)||this._startTooltipTimer(t,e,r,o.x,o.y,i,s)},Smart.Chart.prototype.hideToolTip=function(t){isNaN(t)&&(t=0);const e=this;e._cancelTooltipTimer(),setTimeout((function(){e._hideToolTip(0)}),t)});