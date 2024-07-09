const {add,sub,mul,div} = require ('../src/app')
// const expect = require ('chai').expect 
// Change this :


let expect ;
(async ()=> {
    const chai = await import ('chai');
    expect =chai.expect;
})();






// 1.BDD- 'describe' and 'it'
describe ('suite 1',()=>{
    it('add(2,3) should return 5', ()=>{
        expect(add(2,3)).to.be.equal(5);
    })
})

describe ('suite 2',()=>{
    it('sub(88,33) should return 55', ()=>{
        expect(sub(88,33)).to.be.equal(55);
    })
})
describe ('suite 3',()=>{
    it('mul(5,4) should return 20', ()=>{
        expect(mul(5,4)).to.be.equal(20);
    })
})
// describe ('suite 4',()=>{
//     it('div(25,0) should return undefined ', ()=>{
//         expect(div(25,0)).to.be.equal(undefined);
//     })
// })


