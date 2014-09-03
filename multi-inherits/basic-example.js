function Shape () {
  this.type = '';
}
Shape.prototype.area = function () {
  return (this.len || 0) * (this.width || 0);
};
Shape.prototype.perimeter = function () {
  return 2 * ((this.len || 0) + (this.width || 0));
};

function Rectangle (len, width) {
  Shape.call(this);
  this.type = 'rectangle';
  this.len = len;
  this.width = width;
};
Rectangle.prototype = Object.create(Shape.prototype);
Rectangle.prototype.constructor = Rectangle

var rect1 = new Rectangle(10, 20);
var rect2 = new Rectangle(2, 1000);

console.log('rect1.area\t', rect1.area());
console.log('rect1.perimeter\t', rect1.perimeter());
console.log();
/*
rect1.area      200
rect1.perimeter 60
*/
console.log('rect2.area\t', rect2.area());
console.log('rect2.perimeter\t', rect2.perimeter());
console.log();
/*
rect2.area      2000
rect2.perimeter 2004
 */

function Square (side) {
  Rectangle.call(this, side, side);
}
Square.prototype = Object.create(Rectangle.prototype);
Square.prototype.constructor = Square

var sqr1 = new Square(30);
var sqr2 = new Square(5);

console.log('sqr1.area\t', sqr1.area());
console.log('sqr1.perimeter\t', sqr1.perimeter());
console.log();
/*
sqr1.area      900
sqr1.perimeter 120
*/
console.log('sqr2.area\t', sqr2.area());
console.log('sqr2.perimeter\t', sqr2.perimeter());
console.log();
/*
sqr2.area      25
sqr2.perimeter 20
 */
