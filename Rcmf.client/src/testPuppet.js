const puppeteer = require("puppeteer");

// (async () => {
//   const browser = await puppeteer.launch();
//   const page = await browser.newPage();
//   await page.goto("https://kenjimmy.me");
//   await page.screenshot({ path: "example.png" });

//   await browser.close();
// })();
(async () => {
  const browser = await puppeteer.launch();
  const page = await browser.newPage();
  await page.goto("https://github.com/TriLe1122");
  await page.screenshot({ path: "./assets/img/puppetier/example.png" });

  await browser.close();
})();
