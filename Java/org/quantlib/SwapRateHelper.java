/* ----------------------------------------------------------------------------
 * This file was automatically generated by SWIG (http://www.swig.org).
 * Version 3.0.12
 *
 * Do not make changes to this file unless you know what you are doing--modify
 * the SWIG interface file instead.
 * ----------------------------------------------------------------------------- */

package org.quantlib;

public class SwapRateHelper extends RateHelper {
  private transient long swigCPtr;

  protected SwapRateHelper(long cPtr, boolean cMemoryOwn) {
    super(QuantLibJNI.SwapRateHelper_SWIGUpcast(cPtr), cMemoryOwn);
    swigCPtr = cPtr;
  }

  protected static long getCPtr(SwapRateHelper obj) {
    return (obj == null) ? 0 : obj.swigCPtr;
  }

  protected void finalize() {
    delete();
  }

  public synchronized void delete() {
    if (swigCPtr != 0) {
      if (swigCMemOwn) {
        swigCMemOwn = false;
        QuantLibJNI.delete_SwapRateHelper(swigCPtr);
      }
      swigCPtr = 0;
    }
    super.delete();
  }

  public SwapRateHelper(QuoteHandle rate, Period tenor, Calendar calendar, Frequency fixedFrequency, BusinessDayConvention fixedConvention, DayCounter fixedDayCount, IborIndex index, QuoteHandle spread, Period fwdStart, YieldTermStructureHandle discountingCurve, long settlementDays, Pillar.Choice pillar, Date customPillarDate) {
    this(QuantLibJNI.new_SwapRateHelper__SWIG_0(QuoteHandle.getCPtr(rate), rate, Period.getCPtr(tenor), tenor, Calendar.getCPtr(calendar), calendar, fixedFrequency.swigValue(), fixedConvention.swigValue(), DayCounter.getCPtr(fixedDayCount), fixedDayCount, IborIndex.getCPtr(index), index, QuoteHandle.getCPtr(spread), spread, Period.getCPtr(fwdStart), fwdStart, YieldTermStructureHandle.getCPtr(discountingCurve), discountingCurve, settlementDays, pillar.swigValue(), Date.getCPtr(customPillarDate), customPillarDate), true);
  }

  public SwapRateHelper(QuoteHandle rate, Period tenor, Calendar calendar, Frequency fixedFrequency, BusinessDayConvention fixedConvention, DayCounter fixedDayCount, IborIndex index, QuoteHandle spread, Period fwdStart, YieldTermStructureHandle discountingCurve, long settlementDays, Pillar.Choice pillar) {
    this(QuantLibJNI.new_SwapRateHelper__SWIG_1(QuoteHandle.getCPtr(rate), rate, Period.getCPtr(tenor), tenor, Calendar.getCPtr(calendar), calendar, fixedFrequency.swigValue(), fixedConvention.swigValue(), DayCounter.getCPtr(fixedDayCount), fixedDayCount, IborIndex.getCPtr(index), index, QuoteHandle.getCPtr(spread), spread, Period.getCPtr(fwdStart), fwdStart, YieldTermStructureHandle.getCPtr(discountingCurve), discountingCurve, settlementDays, pillar.swigValue()), true);
  }

  public SwapRateHelper(QuoteHandle rate, Period tenor, Calendar calendar, Frequency fixedFrequency, BusinessDayConvention fixedConvention, DayCounter fixedDayCount, IborIndex index, QuoteHandle spread, Period fwdStart, YieldTermStructureHandle discountingCurve, long settlementDays) {
    this(QuantLibJNI.new_SwapRateHelper__SWIG_2(QuoteHandle.getCPtr(rate), rate, Period.getCPtr(tenor), tenor, Calendar.getCPtr(calendar), calendar, fixedFrequency.swigValue(), fixedConvention.swigValue(), DayCounter.getCPtr(fixedDayCount), fixedDayCount, IborIndex.getCPtr(index), index, QuoteHandle.getCPtr(spread), spread, Period.getCPtr(fwdStart), fwdStart, YieldTermStructureHandle.getCPtr(discountingCurve), discountingCurve, settlementDays), true);
  }

  public SwapRateHelper(QuoteHandle rate, Period tenor, Calendar calendar, Frequency fixedFrequency, BusinessDayConvention fixedConvention, DayCounter fixedDayCount, IborIndex index, QuoteHandle spread, Period fwdStart, YieldTermStructureHandle discountingCurve) {
    this(QuantLibJNI.new_SwapRateHelper__SWIG_3(QuoteHandle.getCPtr(rate), rate, Period.getCPtr(tenor), tenor, Calendar.getCPtr(calendar), calendar, fixedFrequency.swigValue(), fixedConvention.swigValue(), DayCounter.getCPtr(fixedDayCount), fixedDayCount, IborIndex.getCPtr(index), index, QuoteHandle.getCPtr(spread), spread, Period.getCPtr(fwdStart), fwdStart, YieldTermStructureHandle.getCPtr(discountingCurve), discountingCurve), true);
  }

  public SwapRateHelper(QuoteHandle rate, Period tenor, Calendar calendar, Frequency fixedFrequency, BusinessDayConvention fixedConvention, DayCounter fixedDayCount, IborIndex index, QuoteHandle spread, Period fwdStart) {
    this(QuantLibJNI.new_SwapRateHelper__SWIG_4(QuoteHandle.getCPtr(rate), rate, Period.getCPtr(tenor), tenor, Calendar.getCPtr(calendar), calendar, fixedFrequency.swigValue(), fixedConvention.swigValue(), DayCounter.getCPtr(fixedDayCount), fixedDayCount, IborIndex.getCPtr(index), index, QuoteHandle.getCPtr(spread), spread, Period.getCPtr(fwdStart), fwdStart), true);
  }

  public SwapRateHelper(QuoteHandle rate, Period tenor, Calendar calendar, Frequency fixedFrequency, BusinessDayConvention fixedConvention, DayCounter fixedDayCount, IborIndex index, QuoteHandle spread) {
    this(QuantLibJNI.new_SwapRateHelper__SWIG_5(QuoteHandle.getCPtr(rate), rate, Period.getCPtr(tenor), tenor, Calendar.getCPtr(calendar), calendar, fixedFrequency.swigValue(), fixedConvention.swigValue(), DayCounter.getCPtr(fixedDayCount), fixedDayCount, IborIndex.getCPtr(index), index, QuoteHandle.getCPtr(spread), spread), true);
  }

  public SwapRateHelper(QuoteHandle rate, Period tenor, Calendar calendar, Frequency fixedFrequency, BusinessDayConvention fixedConvention, DayCounter fixedDayCount, IborIndex index) {
    this(QuantLibJNI.new_SwapRateHelper__SWIG_6(QuoteHandle.getCPtr(rate), rate, Period.getCPtr(tenor), tenor, Calendar.getCPtr(calendar), calendar, fixedFrequency.swigValue(), fixedConvention.swigValue(), DayCounter.getCPtr(fixedDayCount), fixedDayCount, IborIndex.getCPtr(index), index), true);
  }

  public SwapRateHelper(double rate, Period tenor, Calendar calendar, Frequency fixedFrequency, BusinessDayConvention fixedConvention, DayCounter fixedDayCount, IborIndex index, QuoteHandle spread, Period fwdStart, YieldTermStructureHandle discountingCurve, long settlementDays, Pillar.Choice pillar, Date customPillarDate) {
    this(QuantLibJNI.new_SwapRateHelper__SWIG_7(rate, Period.getCPtr(tenor), tenor, Calendar.getCPtr(calendar), calendar, fixedFrequency.swigValue(), fixedConvention.swigValue(), DayCounter.getCPtr(fixedDayCount), fixedDayCount, IborIndex.getCPtr(index), index, QuoteHandle.getCPtr(spread), spread, Period.getCPtr(fwdStart), fwdStart, YieldTermStructureHandle.getCPtr(discountingCurve), discountingCurve, settlementDays, pillar.swigValue(), Date.getCPtr(customPillarDate), customPillarDate), true);
  }

  public SwapRateHelper(double rate, Period tenor, Calendar calendar, Frequency fixedFrequency, BusinessDayConvention fixedConvention, DayCounter fixedDayCount, IborIndex index, QuoteHandle spread, Period fwdStart, YieldTermStructureHandle discountingCurve, long settlementDays, Pillar.Choice pillar) {
    this(QuantLibJNI.new_SwapRateHelper__SWIG_8(rate, Period.getCPtr(tenor), tenor, Calendar.getCPtr(calendar), calendar, fixedFrequency.swigValue(), fixedConvention.swigValue(), DayCounter.getCPtr(fixedDayCount), fixedDayCount, IborIndex.getCPtr(index), index, QuoteHandle.getCPtr(spread), spread, Period.getCPtr(fwdStart), fwdStart, YieldTermStructureHandle.getCPtr(discountingCurve), discountingCurve, settlementDays, pillar.swigValue()), true);
  }

  public SwapRateHelper(double rate, Period tenor, Calendar calendar, Frequency fixedFrequency, BusinessDayConvention fixedConvention, DayCounter fixedDayCount, IborIndex index, QuoteHandle spread, Period fwdStart, YieldTermStructureHandle discountingCurve, long settlementDays) {
    this(QuantLibJNI.new_SwapRateHelper__SWIG_9(rate, Period.getCPtr(tenor), tenor, Calendar.getCPtr(calendar), calendar, fixedFrequency.swigValue(), fixedConvention.swigValue(), DayCounter.getCPtr(fixedDayCount), fixedDayCount, IborIndex.getCPtr(index), index, QuoteHandle.getCPtr(spread), spread, Period.getCPtr(fwdStart), fwdStart, YieldTermStructureHandle.getCPtr(discountingCurve), discountingCurve, settlementDays), true);
  }

  public SwapRateHelper(double rate, Period tenor, Calendar calendar, Frequency fixedFrequency, BusinessDayConvention fixedConvention, DayCounter fixedDayCount, IborIndex index, QuoteHandle spread, Period fwdStart, YieldTermStructureHandle discountingCurve) {
    this(QuantLibJNI.new_SwapRateHelper__SWIG_10(rate, Period.getCPtr(tenor), tenor, Calendar.getCPtr(calendar), calendar, fixedFrequency.swigValue(), fixedConvention.swigValue(), DayCounter.getCPtr(fixedDayCount), fixedDayCount, IborIndex.getCPtr(index), index, QuoteHandle.getCPtr(spread), spread, Period.getCPtr(fwdStart), fwdStart, YieldTermStructureHandle.getCPtr(discountingCurve), discountingCurve), true);
  }

  public SwapRateHelper(double rate, Period tenor, Calendar calendar, Frequency fixedFrequency, BusinessDayConvention fixedConvention, DayCounter fixedDayCount, IborIndex index, QuoteHandle spread, Period fwdStart) {
    this(QuantLibJNI.new_SwapRateHelper__SWIG_11(rate, Period.getCPtr(tenor), tenor, Calendar.getCPtr(calendar), calendar, fixedFrequency.swigValue(), fixedConvention.swigValue(), DayCounter.getCPtr(fixedDayCount), fixedDayCount, IborIndex.getCPtr(index), index, QuoteHandle.getCPtr(spread), spread, Period.getCPtr(fwdStart), fwdStart), true);
  }

  public SwapRateHelper(double rate, Period tenor, Calendar calendar, Frequency fixedFrequency, BusinessDayConvention fixedConvention, DayCounter fixedDayCount, IborIndex index, QuoteHandle spread) {
    this(QuantLibJNI.new_SwapRateHelper__SWIG_12(rate, Period.getCPtr(tenor), tenor, Calendar.getCPtr(calendar), calendar, fixedFrequency.swigValue(), fixedConvention.swigValue(), DayCounter.getCPtr(fixedDayCount), fixedDayCount, IborIndex.getCPtr(index), index, QuoteHandle.getCPtr(spread), spread), true);
  }

  public SwapRateHelper(double rate, Period tenor, Calendar calendar, Frequency fixedFrequency, BusinessDayConvention fixedConvention, DayCounter fixedDayCount, IborIndex index) {
    this(QuantLibJNI.new_SwapRateHelper__SWIG_13(rate, Period.getCPtr(tenor), tenor, Calendar.getCPtr(calendar), calendar, fixedFrequency.swigValue(), fixedConvention.swigValue(), DayCounter.getCPtr(fixedDayCount), fixedDayCount, IborIndex.getCPtr(index), index), true);
  }

  public SwapRateHelper(QuoteHandle rate, SwapIndex index, QuoteHandle spread, Period fwdStart, YieldTermStructureHandle discountingCurve, Pillar.Choice pillar, Date customPillarDate) {
    this(QuantLibJNI.new_SwapRateHelper__SWIG_14(QuoteHandle.getCPtr(rate), rate, SwapIndex.getCPtr(index), index, QuoteHandle.getCPtr(spread), spread, Period.getCPtr(fwdStart), fwdStart, YieldTermStructureHandle.getCPtr(discountingCurve), discountingCurve, pillar.swigValue(), Date.getCPtr(customPillarDate), customPillarDate), true);
  }

  public SwapRateHelper(QuoteHandle rate, SwapIndex index, QuoteHandle spread, Period fwdStart, YieldTermStructureHandle discountingCurve, Pillar.Choice pillar) {
    this(QuantLibJNI.new_SwapRateHelper__SWIG_15(QuoteHandle.getCPtr(rate), rate, SwapIndex.getCPtr(index), index, QuoteHandle.getCPtr(spread), spread, Period.getCPtr(fwdStart), fwdStart, YieldTermStructureHandle.getCPtr(discountingCurve), discountingCurve, pillar.swigValue()), true);
  }

  public SwapRateHelper(QuoteHandle rate, SwapIndex index, QuoteHandle spread, Period fwdStart, YieldTermStructureHandle discountingCurve) {
    this(QuantLibJNI.new_SwapRateHelper__SWIG_16(QuoteHandle.getCPtr(rate), rate, SwapIndex.getCPtr(index), index, QuoteHandle.getCPtr(spread), spread, Period.getCPtr(fwdStart), fwdStart, YieldTermStructureHandle.getCPtr(discountingCurve), discountingCurve), true);
  }

  public SwapRateHelper(QuoteHandle rate, SwapIndex index, QuoteHandle spread, Period fwdStart) {
    this(QuantLibJNI.new_SwapRateHelper__SWIG_17(QuoteHandle.getCPtr(rate), rate, SwapIndex.getCPtr(index), index, QuoteHandle.getCPtr(spread), spread, Period.getCPtr(fwdStart), fwdStart), true);
  }

  public SwapRateHelper(QuoteHandle rate, SwapIndex index, QuoteHandle spread) {
    this(QuantLibJNI.new_SwapRateHelper__SWIG_18(QuoteHandle.getCPtr(rate), rate, SwapIndex.getCPtr(index), index, QuoteHandle.getCPtr(spread), spread), true);
  }

  public SwapRateHelper(QuoteHandle rate, SwapIndex index) {
    this(QuantLibJNI.new_SwapRateHelper__SWIG_19(QuoteHandle.getCPtr(rate), rate, SwapIndex.getCPtr(index), index), true);
  }

  public SwapRateHelper(double rate, SwapIndex index, QuoteHandle spread, Period fwdStart, YieldTermStructureHandle discountingCurve, Pillar.Choice pillar, Date customPillarDate) {
    this(QuantLibJNI.new_SwapRateHelper__SWIG_20(rate, SwapIndex.getCPtr(index), index, QuoteHandle.getCPtr(spread), spread, Period.getCPtr(fwdStart), fwdStart, YieldTermStructureHandle.getCPtr(discountingCurve), discountingCurve, pillar.swigValue(), Date.getCPtr(customPillarDate), customPillarDate), true);
  }

  public SwapRateHelper(double rate, SwapIndex index, QuoteHandle spread, Period fwdStart, YieldTermStructureHandle discountingCurve, Pillar.Choice pillar) {
    this(QuantLibJNI.new_SwapRateHelper__SWIG_21(rate, SwapIndex.getCPtr(index), index, QuoteHandle.getCPtr(spread), spread, Period.getCPtr(fwdStart), fwdStart, YieldTermStructureHandle.getCPtr(discountingCurve), discountingCurve, pillar.swigValue()), true);
  }

  public SwapRateHelper(double rate, SwapIndex index, QuoteHandle spread, Period fwdStart, YieldTermStructureHandle discountingCurve) {
    this(QuantLibJNI.new_SwapRateHelper__SWIG_22(rate, SwapIndex.getCPtr(index), index, QuoteHandle.getCPtr(spread), spread, Period.getCPtr(fwdStart), fwdStart, YieldTermStructureHandle.getCPtr(discountingCurve), discountingCurve), true);
  }

  public SwapRateHelper(double rate, SwapIndex index, QuoteHandle spread, Period fwdStart) {
    this(QuantLibJNI.new_SwapRateHelper__SWIG_23(rate, SwapIndex.getCPtr(index), index, QuoteHandle.getCPtr(spread), spread, Period.getCPtr(fwdStart), fwdStart), true);
  }

  public SwapRateHelper(double rate, SwapIndex index, QuoteHandle spread) {
    this(QuantLibJNI.new_SwapRateHelper__SWIG_24(rate, SwapIndex.getCPtr(index), index, QuoteHandle.getCPtr(spread), spread), true);
  }

  public SwapRateHelper(double rate, SwapIndex index) {
    this(QuantLibJNI.new_SwapRateHelper__SWIG_25(rate, SwapIndex.getCPtr(index), index), true);
  }

  public double spread() {
    return QuantLibJNI.SwapRateHelper_spread(swigCPtr, this);
  }

  public VanillaSwap swap() {
    return new VanillaSwap(QuantLibJNI.SwapRateHelper_swap(swigCPtr, this), true);
  }

}
