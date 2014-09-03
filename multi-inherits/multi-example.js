
var _ = require('lodash');

function Shape () {
  this.type = '';
}
Shape.prototype.area = function () {
  return (this.len || 0) * (this.width || 0);
};
Shape.prototype.perimeter = function () {
  return 2 * ((this.len || 0) + (this.width || 0));
};

function Movable () {
  this.x = 0;
  this.y = 0;
}

Movable.prototype.move = function(x, y) {
  this.x += x;
  this.y += y;
  console.info(this.type || '', "moved.");
};

Movable.prototype.location = function() {
  return '(' + this.x + ', ' + this.y + ')';
};

function Rectangle(len, width) {
  Shape.call(this);
  Movable.call(this);
  this.type = 'rectangle';
  this.len = len;
  this.width = width;
}

Rectangle.prototype = Object.create(Shape.prototype);
Rectangle.prototype.constructor = Rectangle;
_.extend(Rectangle.prototype, Movable.prototype);

var rect = new Rectangle(10, 20);

console.log('rect.area\t', rect.area());
console.log('rect.perimeter\t', rect.perimeter());
console.log('rect.location1\t', rect.location());
rect.move(10, 20);
console.log('rect.location2\t', rect.location());
console.log();
/*
rect.area         200
rect.perimeter    60
rect.location1    (0, 0)
rectangle moved.
rect.location2    (10, 20)
*/

function Square (side) {
  Rectangle.call(this, side, side);
  this.type = 'square';
}
Square.prototype = Object.create(Rectangle.prototype);
Square.prototype.constructor = Square

var sqr = new Square(30);

console.log('sqr.area\t', sqr.area());
console.log('sqr.perimeter\t', sqr.perimeter());
console.log('sqr.location1\t', sqr.location());
sqr.move(5, -20);
console.log('sqr.location2\t', sqr.location());

console.log();
/*
sqr.area        900
sqr.perimeter   120
sqr.location1   (0, 0)
square moved.
sqr.location2   (5, -20)
*/



