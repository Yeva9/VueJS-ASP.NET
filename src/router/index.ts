import { createRouter, createWebHistory, RouteRecordRaw } from 'vue-router'
import HomeView from '../views/HomeView.vue'
import AboutView from '../views/AboutView.vue'
import JobDetailes from '../views/JobDetailes.vue'
import JobsList from '../components/JobsList.vue'

const routes: Array<RouteRecordRaw> = [
  {
    path: '/',
    name: 'home',
    component: HomeView
  },
  {
    path: '/about',
    name: 'aboutt',
    component: AboutView
  },
  {
    path: '/jobs',
    name: 'JobList',
    component: JobsList
  },
  {
    path: '/jobs/:id',
    name: 'JobDetailes',
    component: JobDetailes
  }
]

const router = createRouter({
  history: createWebHistory(process.env.BASE_URL),
  routes
})

export default router
