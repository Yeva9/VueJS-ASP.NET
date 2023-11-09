import { ref } from 'vue'

const getJobs = () => {
  const jobApiUrl ='https://localhost:3200/api/'

  const jobs = ref([])
  const error = ref(null)

  const load = async () => {
    try {
      const data = await fetch(`${jobApiUrl}jobs`)
      if(!data.ok) {
        throw Error('no available data')
      }
      jobs.value = await data.json()
    }
    catch(err : any) { // todo: fix
      error.value = err.message
    }
  }

  return { jobs, error, load }
}

export default getJobs