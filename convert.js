var fs = require('fs');

var fileContents = fs.readFileSync('cartoon_heroes.muse', 'utf8');
var lines = fileContents.split('\r\n');

var measures = [[]];

lines.forEach(line => {
  if (line.startsWith(',')) {
    measures.push([]);
  }
  else {
    if(line) {
      measures[measures.length-1].push(line);
    }
  }
});

for (var i = 0; i < measures.length; i++) {
  var beatsPerThing = 4.0 / measures[i].length;
  var measureStart = i * 4;

  for (var j = 0; j < measures[i].length; j++) {
    var beat = measureStart + beatsPerThing * j;
    var time = beat * 6 / 17.0;
    time = time + 0.049;

    for (var k = 0; k < 4; k++) {
      if (measures[i][j][k] !== '0') {
        console.log('' + time + ' ' + k);
      }
    }
  }
}
