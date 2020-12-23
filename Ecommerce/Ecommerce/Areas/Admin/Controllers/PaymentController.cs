﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Ecommerce.Areas.Admin.Data;
using Ecommerce.Areas.Admin.Models;
using System.IO;
using Microsoft.AspNetCore.Http;

namespace Ecommerce.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class PaymentController : Controller
    {
        private readonly DPContext _context;

        public PaymentController(DPContext context)
        {
            _context = context;
        }

        // GET: Admin/Payment
        public async Task<IActionResult> Index()
        {
            return View(await _context.Payments.ToListAsync());
        }

        // GET: Admin/Payment/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var paymentModel = await _context.Payments
                .FirstOrDefaultAsync(m => m.PaymentID == id);
            if (paymentModel == null)
            {
                return NotFound();
            }

            return View(paymentModel);
        }

        // GET: Admin/Payment/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Admin/Payment/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("PaymentID,Name,Logo,Status")] PaymentModel paymentModel, IFormFile ful)
        {
            if (ModelState.IsValid)
            {
                _context.Add(paymentModel);
                //Image.UploadPicture(sliderModel.SliderID, sliderModel.Picture, ful);
                var path = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/image/payment", paymentModel.PaymentID + "." + ful.FileName.Split(".")[ful.FileName.Split(".").Length - 1]);
                using (var stream = new FileStream(path, FileMode.Create))
                {
                    await ful.CopyToAsync(stream);
                }
                paymentModel.Logo = paymentModel.PaymentID + "." + ful.FileName.Split(".")[ful.FileName.Split(".").Length - 1];
                _context.Add(paymentModel);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(paymentModel);
        }

        // GET: Admin/Payment/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var paymentModel = await _context.Payments.FindAsync(id);
            if (paymentModel == null)
            {
                return NotFound();
            }
            return View(paymentModel);
        }

        // POST: Admin/Payment/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("PaymentID,Name,Logo,Status")] PaymentModel paymentModel, IFormFile ful)
        {
            if (id != paymentModel.PaymentID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Add(paymentModel);
                    //Image.UploadPicture(sliderModel.SliderID, sliderModel.Picture, ful);
                    var path = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/image/payment", paymentModel.PaymentID + "." + ful.FileName.Split(".")[ful.FileName.Split(".").Length - 1]);
                    using (var stream = new FileStream(path, FileMode.Create))
                    {
                        await ful.CopyToAsync(stream);
                    }
                    paymentModel.Logo = paymentModel.PaymentID + "." + ful.FileName.Split(".")[ful.FileName.Split(".").Length - 1];
                    _context.Update(paymentModel);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!PaymentModelExists(paymentModel.PaymentID))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            return View(paymentModel);
        }

        // GET: Admin/Payment/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var paymentModel = await _context.Payments
                .FirstOrDefaultAsync(m => m.PaymentID == id);
            if (paymentModel == null)
            {
                return NotFound();
            }

            return View(paymentModel);
        }

        // POST: Admin/Payment/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var paymentModel = await _context.Payments.FindAsync(id);
            _context.Payments.Remove(paymentModel);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool PaymentModelExists(int id)
        {
            return _context.Payments.Any(e => e.PaymentID == id);
        }
    }
}
