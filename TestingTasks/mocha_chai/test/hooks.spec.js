
const {add,sub,mul,div} = require ('../src/app')

// const expect =require ('chai').expect


let expect ;
(async ()=> {
    const chai = await import ('chai');
    expect =chai.expect;
})();

describe('suite 4', () =>{
    after(()=>{
        console.log('after')
    });

    before(()=>{
        console.log('before')
    });
    afterEach(()=>{
        console.log('aftereach')
    });
    beforeEach(()=>{
        console.log('beforeeach')
    });
    describe ('suite 1',()=>{
        it('add(2,3) should return 5', ()=>{
            expect(add(2,3)).to.be.equal(5);
        })
    })



});

