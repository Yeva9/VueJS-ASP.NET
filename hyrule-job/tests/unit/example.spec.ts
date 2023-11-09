import { shallowMount } from '@vue/test-utils'
import JobsList from '@/components/JobsList.vue'
import OrderTerm from '@/types/OrderTerm'
import Job from '@/types/Job'
import { ref } from 'vue'

// describe('JobsList.vue', () => {
//   it('renders props.msg when passed', () => {
//     const jobs = ref<Job[]>([
//       { title: 'farm worker', location: 'lon lon ranch', salary: 30000, id: '1', isFav: false },
//       { title: 'quarryman', location: 'death mountain', salary: 40000, id: '2', isFav: true },
//       { title: 'flute player', location: 'the lost woods', salary: 35000, id: '3', isFav: true },
//       { title: 'fisherman', location: 'lake hylia', salary: 21000, id: '4', isFav: true },
//       { title: 'prison guard', location: 'gerudo valley', salary: 32000, id: '5', isFav: false }
//     ]);

//     const order = ref<OrderTerm>('title'); 

//     const wrapper = shallowMount(JobsList, {
//       props: { 
//         jobs,
//         order
//        }
//     })
//     expect(wrapper.props()).equal(jobs)
//   })
// })
