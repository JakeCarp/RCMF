import { createRouter, createWebHashHistory } from 'vue-router'
import { authGuard } from '@bcwdev/auth0provider-client'

function loadPage(page) {
  return () => import(`./pages/${page}.vue`)
}

const routes = [
  {
    path: '/',
    name: 'Home',
    component: loadPage('HomePage')
  },
  {
    path: '/sponsor',
    name: 'Sponsor',
    component: loadPage('SponsorPage')
  },
  {
    path: '/tournament',
    name: 'Tournament',
    component: loadPage('TournamentPage')
  },
  {
    path: '/donate',
    name: 'Donate',
    component: loadPage('TournamentPage')
  },
  {
    path: '/about',
    name: 'About',
    component: loadPage('AboutPage')
  },
  {
    path: '/admin',
    name: 'Admin',
    component: loadPage('AdminPage'),
    beforeEnter: authGuard
  }
]

export const router = createRouter({
  linkActiveClass: 'router-link-active',
  linkExactActiveClass: 'router-link-exact-active',
  history: createWebHashHistory(),
  routes
})
