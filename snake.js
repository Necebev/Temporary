const canvas = document.getElementById("gamecanvas")
const ctx = canvas.getContext("2d");
const w = canvas.width
const h = canvas.height
const sqr = 60 /* egy négyzet mérete */
var ranx = Math.floor(Math.random()*12)
var rany = Math.floor(Math.random()*10)
var posx = sqr*ranx
var posy = sqr*rany
var n = 0




ctx.fillStyle ="#d4ac50";
ctx.fillRect(0,0,w,h);
ctx.fillStyle ="#d4b15f"; 
for (let i = 0; i < sqr; i++) {
  for (let j = 0; j < sqr; j++) {
    ctx.fillRect(sqr*2*i, sqr*2*j, sqr, sqr)
    ctx.fillRect(sqr*2*i+sqr, sqr*2*j+sqr, sqr, sqr)
  }
}



ctx.fillStyle = "Green";
ctx.fillRect(posx+15, posy+15, sqr-30, sqr-30)
