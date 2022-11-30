import '@mdi/font/css/materialdesignicons.css'
import 'bootstrap'
// import app from ''
import { createApp } from 'vue'
// @ts-ignore
import App from './App.vue'
import { MotionPlugin } from "@vueuse/motion";
import { registerGlobalComponents } from './registerGlobalComponents'
import { router } from './router'

const root = createApp(App)
registerGlobalComponents(root)

root.use(router).use(MotionPlugin).mount("#app");
