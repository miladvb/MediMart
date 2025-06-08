"use client";

import { f_Beiruti } from "./libs/fonts";
import { GiMedicines } from "react-icons/gi";
import { IoIosAttach } from "react-icons/io";

export default function Home() {
  return (
    <main className="flex-1 flex flex-col items-center justify-center !mb-10  gap-4">
      <h1 className={`${f_Beiruti.className} font-bold text-2xl lg:text-2xl text-gray-900`}>
        چه دارویی رو میخوای پیدا کنی؟
      </h1>
      <div className=" border-[1px] border-gray-200 rounded-[28px] shadow-lg shadow-gray-200 w-full sm:w-3/4 md:w-3/4  lg:w-2/4">
        <div className=" w-full !py-5 !px-5 ">
          <input
            type="text"
            name="txtDrug"
            id="txtDrug"
            className="w-full focus:outline-0 "
            placeholder="لطفا نام دارو را بنویسید."
          />
        </div>
        <div className="flex flex-row justify-between">
          <div className="!pb-3 !pr-3">
            <button
              aria-label="Upload image file"
              className="h-9 min-h-8 w-9 flex items-center justify-center rounded-full border text-[#5d5d5d] border-[rgba(0,0,0,.1)] hover:hover:bg-black/5 dark:hover:hover:bg-white/5min-w-[34px]"
            >
              <div className="flex items-center justify-center ">
                <IoIosAttach size={25} />
              </div>
            </button>
          </div>
          <div className="!pb-3 !pl-3">
            <button
              aria-label="Search data for find drug"
              className=" h-9 w-9 flex items-center justify-center rounded-full bg-black text-white transition-colors focus-visible:outline-none focus-visible:outline-black disabled:text-gray-50 disabled:opacity-30 hover:hover:opacity-70 dark:bg-white dark:text-black cursor-pointer"
            >
              <div className="flex items-center justify-center ">
                <GiMedicines size={25} />
              </div>
            </button>
          </div>
        </div>
      </div>
    </main>
  );
}

