const canvas = document.getElementById("canvas");
const ctx = canvas.getContext("2d");
let snake = [ {x: 320, y: 320}, {x: 310, y: 320}, {x: 300, y: 320}]

main();


function main() {
  Canvas();
  drawsnake();
}

function Canvas() {
  ctx.fillStyle = "darkgreen";
}

function drawsnake() {
  snake.forEach(drawpart)
}

function drawpart(snakepart) {
  ctx.fillstyle = "green"
  ctx,fillRect

}