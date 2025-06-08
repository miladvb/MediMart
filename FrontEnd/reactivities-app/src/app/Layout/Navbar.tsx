"use client";
import React, { useEffect, useState } from "react";
import Link from "next/link";

import { FaUserCircle } from "react-icons/fa";

const menuLinks = [
  { path: "/", lable: "صفحه اصلی" },
  { path: "/Services", lable: "داروخانه‌ها" },
  { path: "/Profile", lable: "مقایسه قیمت" },
  { path: "/Profile", lable: "درباره ما" },
];

export default function Navbar() {
  const [isOpen, setIsOpen] = useState<boolean>(false);

  const toggleMenu = () => {
    setIsOpen(!isOpen);
  };

  useEffect(() => {
    toggleMenu();
  }, []);

  return (
    <header className="bg-white shadow-sm">
      <div className="container mx-auto px-4 py-3 flex justify-between items-center">
        <div className="flex items-center space-x-4 space-x-reverse">
          <div className="text-blue-600 text-2xl font-bold">داروجو</div>
          <nav className="hidden md:flex space-x-6 space-x-reverse">
            {menuLinks.map((link, index) => (
              <Link href={link.path} key={index} className="text-gray-700 hover:text-blue-600">
                {link.lable}
              </Link>
            ))}
          </nav>
        </div>
        <div className="flex items-center space-x-3 space-x-reverse">
          <a className="text-gray-600 hover:text-blue-600">
            <i className="fas fa-user-circle text-xl">
              <FaUserCircle />
            </i>
          </a>
          <a className="md:hidden text-gray-600">
            <i className="fas fa-bars text-xl"></i>
          </a>
        </div>
      </div>
    </header>
  );
}
